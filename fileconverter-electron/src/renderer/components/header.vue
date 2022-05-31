<template>
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
    <div class="flex justify-">
      <div class="sm:hidden">
        <label for="tabs" class="sr-only">Select a tab</label>
        <!-- Use an "onChange" listener to redirect the user to the selected tab URL. -->
        <select id="tabs" name="tabs"
          class="block w-full focus:ring-indigo-500 focus:border-indigo-500 border-gray-300 rounded-md">
          <option>Conversion Presets</option>

          <option>Application</option>

          <option selected>About</option>
        </select>
      </div>
      <div class="hidden sm:block">
        <nav class="flex border rounded space-x-4" aria-label="Tabs">
          <!-- Current: "bg-gray-100 text-gray-700", Default: "text-gray-500 hover:text-gray-700" -->
          <a href="#" class="text-gray-500 hover:text-gray-700 px-3 py-2 font-medium text-sm rounded-md">Conversion
            Presets</a>

          <a href="#" class="text-gray-500 hover:text-gray-700 px-3 py-2 font-medium text-sm rounded-md">Application</a>

          <a href="#" class="bg-gray-100 text-gray-700 px-3 py-2 font-medium text-sm rounded-md"
            aria-current="page">About</a>

        </nav>
        <!--<ConvPreset/>-->
      </div>
    </div>
</template>

<script>
export default {

}
</script>

<style>

</style>