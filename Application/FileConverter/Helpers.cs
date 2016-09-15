﻿// // <copyright file="Helpers.cs" company="AAllard">License: http://www.gnu.org/licenses/gpl.html GPL version 3.</copyright>

namespace FileConverter
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.IO;
    using System.Linq;
    using System.Reflection;
    using System.Threading;

    using Microsoft.Win32;

    public static class Helpers
    {
        private static readonly string[] CompatibleOfficeVersions = new string[]
        {
            "16.0", // Office 2016
            "15.0", // Office 2013
            "14.0", // Office 2010
            ////"12.0", // Office 2007
            ////"11.0", // Office 2003
            ////"10.0", // Office XP
            ////"9.0", // Office 2000
            ////"8.0", // Office 98
            ////"7.0", // Office 97
        };

        public static IEnumerable<CultureInfo> GetSupportedCultures()
        {
            // Get all cultures.
            CultureInfo[] cultures = CultureInfo.GetCultures(CultureTypes.AllCultures);

            // Find the location where application installed.
            string exeLocation = Path.GetDirectoryName(Uri.UnescapeDataString(new UriBuilder(Assembly.GetExecutingAssembly().CodeBase).Path));

            // Return all culture for which satellite folder found with culture code.
            return cultures.Where(cultureInfo => Directory.Exists(Path.Combine(exeLocation, "Languages", cultureInfo.Name)));
        }

        public static string GetExtensionCategory(string extension)
        {
            switch (extension)
            {
                case "aac":
                case "aiff":
                case "ape":
                case "cda":
                case "flac":
                case "mp3":
                case "m4a":
                case "oga":
                case "ogg":
                case "wav":
                case "wma":
                    return InputCategoryNames.Audio;

                case "3gp":
                case "avi":
                case "bik":
                case "flv":
                case "m4v":
                case "mp4":
                case "mpeg":
                case "mov":
                case "mkv":
                case "ogv":
                case "vob":
                case "webm":
                case "wmv":
                    return InputCategoryNames.Video;

                case "bmp":
                case "exr":
                case "ico":
                case "jpg":
                case "jpeg":
                case "png":
                case "psd":
                case "tga":
                case "tiff":
                case "svg":
                case "xcf":
                case "webp":
                    return InputCategoryNames.Image;

                case "gif":
                    return InputCategoryNames.AnimatedImage;

                case "pdf":
                case "doc":
                case "docx":
                case "ppt":
                case "pptx":
                case "odp":
                case "ods":
                case "odt":
                case "xls":
                case "xlsx":
                    return InputCategoryNames.Document;
            }

            return InputCategoryNames.Misc;
        }

        public static bool IsOutputTypeCompatibleWithCategory(OutputType outputType, string category)
        {
            if (category == InputCategoryNames.Misc)
            {
                // Misc category contains unsorted input extensions, so we consider that they are compatible to be tolerant.
                return true;
            }

            switch (outputType)
            {
                case OutputType.Aac:
                case OutputType.Flac:
                case OutputType.Mp3:
                case OutputType.Ogg:
                case OutputType.Wav:
                    return category == InputCategoryNames.Audio || category == InputCategoryNames.Video;

                case OutputType.Avi:
                case OutputType.Mkv:
                case OutputType.Mp4:
                case OutputType.Ogv:
                case OutputType.Webm:
                    return category == InputCategoryNames.Video || category == InputCategoryNames.AnimatedImage;

                case OutputType.Ico:
                case OutputType.Jpg:
                case OutputType.Png:
                case OutputType.Webp:
                    return category == InputCategoryNames.Image || category == InputCategoryNames.Document;

                case OutputType.Gif:
                    return category == InputCategoryNames.Image || category == InputCategoryNames.Video || category == InputCategoryNames.AnimatedImage;

                case OutputType.Pdf:
                    return category == InputCategoryNames.Image || category == InputCategoryNames.Document;

                default:
                    return false;
            }
        }

        public static Thread InstantiateThread(string name, ThreadStart threadStart)
        {
            Application application = Application.Current as Application;
            CultureInfo currentCulture = application?.Settings?.ApplicationLanguage;

            Thread thread = new Thread(threadStart);
            thread.Name = name;

            if (currentCulture != null)
            {
                thread.CurrentCulture = currentCulture;
                thread.CurrentUICulture = currentCulture;
            }

            return thread;
        }

        public static Thread InstantiateThread(string name, ParameterizedThreadStart parameterizedThreadStart)
        {
            Application application = Application.Current as Application;
            CultureInfo currentCulture = application?.Settings?.ApplicationLanguage;

            Thread thread = new Thread(parameterizedThreadStart);
            thread.Name = name;

            if (currentCulture != null)
            {
                thread.CurrentCulture = currentCulture;
                thread.CurrentUICulture = currentCulture;
            }

            return thread;
        }

        /// <summary>
        /// Check whether Microsoft office is available or not.
        /// </summary>
        /// <returns>Returns true if Office is installed on the computer.</returns>
        /// source: http://stackoverflow.com/questions/3266675/how-to-detect-installed-version-of-ms-office/3267832#3267832
        public static bool IsMicrosoftOfficeAvailable()
        {
            string registryKeyPattern = @"Software\Microsoft\Office\{0}\Common";

            for (int index = 0; index < Helpers.CompatibleOfficeVersions.Length; index++)
            {
                string registryKeyPath = string.Format(registryKeyPattern, Helpers.CompatibleOfficeVersions[index]);
                RegistryKey officeRegistryKey = Microsoft.Win32.Registry.LocalMachine.OpenSubKey(registryKeyPath);
                if (officeRegistryKey != null)
                {
                    Diagnostics.Debug.Log($"Registry key '{registryKeyPath}' found");
                    return true;
                }
            }

            Diagnostics.Debug.Log("No compatible office version found.");
            return false;
        }

        public static bool IsExtensionCompatibleWithOffice(string extension)
        {
            switch (extension)
            {
                case "doc":
                case "docx":
                case "ppt":
                case "pptx":
                case "odp":
                case "ods":
                case "odt":
                case "xls":
                case "xlsx":
                    return true;
            }

            return false;
        }

        public static class InputCategoryNames
        {
            public const string Audio = "Audio";
            public const string Video = "Video";
            public const string Image = "Image";
            public const string AnimatedImage = "Animated Image";
            public const string Document = "Document";

            public const string Misc = "Misc";
        }
    }
}