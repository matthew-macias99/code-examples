import { defineConfig } from 'vite'
import react from '@vitejs/plugin-react'

// https://vite.dev/config/
export default defineConfig({
  plugins: [react()],
  base: '/AWD100-final-project/',
  server: {
    open: true,
    port: 5173,
    fs: {
      strict: false
    }
  }
});
