/**
 * By default, Nuxt.js is configured to cover most use cases.
 * This default configuration can be overwritten in this file
 * @link {https://nuxtjs.org/guide/configuration/}
 */


module.exports = {
  ssr: false,
  target: 'static',
  head: {
    title: 'fileconverter-electron',
    meta: [{ charset: "utf-8" }],
   
  },
  loading: false,
  plugins: [
    
    
    
  ],
  buildModules: [
    '@nuxt/postcss8'

  ],
  build: {
    postcss: {
      plugins: {
        tailwindcss: {
          config: './tailwind.config.js',
        },
        autoprefixer: {},
      },
    },
  },
  modules: [
    
  ],
  css: [
    '@/assets/css/tailwind.css'
  ],
};
