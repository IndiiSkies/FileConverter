<template>
  <div>
    <!--
  This example requires Tailwind CSS v2.0+ 
  
  This example requires some changes to your config:
  
  ```
  // tailwind.config.js
  module.exports = {
    // ...
    plugins: [
      // ...
      require('@tailwindcss/forms'),
    ],
  }
  ```
-->
    <fieldset class="space-y-5 border">
      <legend class="sr-only">Notifications</legend>
      <div class="relative flex items-start">
        <div class="flex items-center h-5">
          <input id="comments" aria-describedby="comments-description" name="comments" type="checkbox"
            class="focus:ring-indigo-500 h-4 w-4 text-indigo-600 border-gray-300 rounded">
        </div>
        <div class="ml-3 text-sm">
          <label for="comments" class="font-medium text-gray-700">To Mkv</label>
        </div>
      </div>
      <div class="relative flex items-start">
        <div class="flex items-center h-5">
          <input id="candidates" aria-describedby="candidates-description" name="candidates" type="checkbox"
            class="focus:ring-indigo-500 h-4 w-4 text-indigo-600 border-gray-300 rounded">
        </div>
        <div class="ml-3 text-sm">
          <label for="candidates" class="font-medium text-gray-700">To Mp4</label>
        </div>
      </div>
      <div class="relative flex items-start">
        <div class="flex items-center h-5">
          <input id="offers" aria-describedby="offers-description" name="offers" type="checkbox"
            class="focus:ring-indigo-500 h-4 w-4 text-indigo-600 border-gray-300 rounded">
        </div>

        <div class="relative flex items-start">
          <div class="ml-3 text-sm">
            <label for="offers" class="font-medium text-gray-700">To Mp4 (low quality)</label>
          </div>
        </div>

      </div>

        <div class="relative flex items-start">
        <div class="flex items-center h-5">
          <input id="offers" aria-describedby="offers-description" name="offers" type="checkbox"
            class="focus:ring-indigo-500 h-4 w-4 text-indigo-600 border-gray-300 rounded">
        </div>
          <div class="ml-3 text-sm">
            <label for="offers" class="font-medium text-gray-700">To Mp4 (rotate left)</label>
          </div>
        </div>

        <div class="relative flex items-start">
        <div class="flex items-center h-5">
          <input id="offers" aria-describedby="offers-description" name="offers" type="checkbox"
            class="focus:ring-indigo-500 h-4 w-4 text-indigo-600 border-gray-300 rounded">
        </div>

          <div class="ml-3 text-sm">
            <label for="offers" class="font-medium text-gray-700">To Mp4 (rotate right)</label>
          </div>
        </div>

        <div class="relative flex items-start">
        <div class="flex items-center h-5">
          <input id="offers" aria-describedby="offers-description" name="offers" type="checkbox"
            class="focus:ring-indigo-500 h-4 w-4 text-indigo-600 border-gray-300 rounded">
        </div>

          <div class="ml-3 text-sm">
            <label for="offers" class="font-medium text-gray-700">To Webm</label>
          </div>
        </div>

        <div class="relative flex items-start">
        <div class="flex items-center h-5">
          <input id="offers" aria-describedby="offers-description" name="offers" type="checkbox"
            class="focus:ring-indigo-500 h-4 w-4 text-indigo-600 border-gray-300 rounded">
        </div>

          <div class="ml-3 text-sm">
            <label for="offers" class="font-medium text-gray-700">To Ogv</label>
          </div>
        </div>

        <div class="relative flex items-start">
        <div class="flex items-center h-5">
          <input id="offers" aria-describedby="offers-description" name="offers" type="checkbox"
            class="focus:ring-indigo-500 h-4 w-4 text-indigo-600 border-gray-300 rounded">
        </div>

          <div class="ml-3 text-sm">
            <label for="offers" class="font-medium text-gray-700">To Avi</label>
          </div>
        </div>

        <div class="relative flex items-start">
        <div class="flex items-center h-5">
          <input id="offers" aria-describedby="offers-description" name="offers" type="checkbox"
            class="focus:ring-indigo-500 h-4 w-4 text-indigo-600 border-gray-300 rounded">
        </div>

          <div class="ml-3 text-sm">
            <label for="offers" class="font-medium text-gray-700">To Gif</label>
          </div>
        </div>

        <div class="relative flex items-start">
          <div class="flex items-center h-5">
          <input id="offers" aria-describedby="offers-description" name="offers" type="checkbox"
            class="focus:ring-indigo-500 h-4 w-4 text-indigo-600 border-gray-300 rounded">
        </div>

          <div class="ml-3 text-sm">
            <label for="offers" class="font-medium text-gray-700">To Gif (low quality)</label>
          </div>
        </div>

        <div class="relative flex items-start">
          <div class="flex items-center h-5">
          <input id="offers" aria-describedby="offers-description" name="offers" type="checkbox"
            class="focus:ring-indigo-500 h-4 w-4 text-indigo-600 border-gray-300 rounded">
        </div>

          <div class="ml-3 text-sm">
            <label for="offers" class="font-medium text-gray-700">To Ogg</label>
          </div>
        </div>

        <div class="relative flex items-start">
        <div class="flex items-center h-5">
          <input id="offers" aria-describedby="offers-description" name="offers" type="checkbox"
            class="focus:ring-indigo-500 h-4 w-4 text-indigo-600 border-gray-300 rounded">
        </div>

          <div class="ml-3 text-sm">
            <label for="offers" class="font-medium text-gray-700">To Flac</label>
          </div>
        </div>

        <div class="relative flex items-start">
          <div class="flex items-center h-5">
          <input id="offers" aria-describedby="offers-description" name="offers" type="checkbox"
            class="focus:ring-indigo-500 h-4 w-4 text-indigo-600 border-gray-300 rounded">
        </div>

          <div class="ml-3 text-sm">
            <label for="offers" class="font-medium text-gray-700">To Wav</label>
          </div>
        </div>

        <div class="relative flex items-start">
        <div class="flex items-center h-5">
          <input id="offers" aria-describedby="offers-description" name="offers" type="checkbox"
            class="focus:ring-indigo-500 h-4 w-4 text-indigo-600 border-gray-300 rounded">
        </div>

          <div class="ml-3 text-sm">
            <label for="offers" class="font-medium text-gray-700">To Mp4</label>
          </div>
        </div>
    </fieldset>
    <span class="block">Action when conversion</span>
<!-- This example requires Tailwind CSS v2.0+ -->
<div class="relative inline-block text-left">
  <div>
    <button type="button" class="inline-flex justify-center w-full rounded-md border border-gray-300 shadow-sm px-4 py-2 bg-white text-sm font-medium text-gray-700 hover:bg-gray-50 focus:outline-none focus:ring-2 focus:ring-offset-2 focus:ring-offset-gray-100 focus:ring-indigo-500" id="menu-button" aria-expanded="true" aria-haspopup="true">
      None
      <!-- Heroicon name: solid/chevron-down -->
      <svg class="-mr-1 ml-2 h-5 w-5" xmlns="http://www.w3.org/2000/svg" viewBox="0 0 20 20" fill="currentColor" aria-hidden="true">
        <path fill-rule="evenodd" d="M5.293 7.293a1 1 0 011.414 0L10 10.586l3.293-3.293a1 1 0 111.414 1.414l-4 4a1 1 0 01-1.414 0l-4-4a1 1 0 010-1.414z" clip-rule="evenodd" />
      </svg>
    </button>
  </div>

  <!--
    Dropdown menu, show/hide based on menu state.

    Entering: "transition ease-out duration-100"
      From: "transform opacity-0 scale-95"
      To: "transform opacity-100 scale-100"
    Leaving: "transition ease-in duration-75"
      From: "transform opacity-100 scale-100"
      To: "transform opacity-0 scale-95"
  -->
  <div class="origin-top-right absolute right-0 mt-2 w-56 rounded-md shadow-lg bg-white ring-1 ring-black ring-opacity-5 focus:outline-none" role="menu" aria-orientation="vertical" aria-labelledby="menu-button" tabindex="-1">
    <div class="py-1" role="none">
      <!-- Active: "bg-gray-100 text-gray-900", Not Active: "text-gray-700" -->
      <a href="#" class="text-gray-700 block px-4 py-2 text-sm" role="menuitem" tabindex="-1" id="menu-item-0">Account settings</a>
      <a href="#" class="text-gray-700 block px-4 py-2 text-sm" role="menuitem" tabindex="-1" id="menu-item-1">Support</a>
      <a href="#" class="text-gray-700 block px-4 py-2 text-sm" role="menuitem" tabindex="-1" id="menu-item-2">License</a>
      <form method="POST" action="#" role="none">
        <button type="submit" class="text-gray-700 block w-full text-left px-4 py-2 text-sm" role="menuitem" tabindex="-1" id="menu-item-3">Sign out</button>
      </form>
    </div>
  </div>
</div>

  </div>
</template>

<script>
export default {
    name: 'InputFormat',
}
</script>

<style>

</style>