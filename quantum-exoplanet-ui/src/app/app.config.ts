import { ApplicationConfig, provideBrowserGlobalErrorListeners } from '@angular/core';
import { provideRouter } from '@angular/router';
import { provideHttpClient } from '@angular/common/http';

import { routes } from './app.routes';
import { provideClientHydration, withEventReplay } from '@angular/platform-browser';

export const appConfig: ApplicationConfig = {
  providers: [
    provideBrowserGlobalErrorListeners(),

    // Routing
    provideRouter(routes),

    // Angular SSR hydration
    provideClientHydration(withEventReplay()),

    // HTTP client for API calls
    provideHttpClient()
  ]
};
