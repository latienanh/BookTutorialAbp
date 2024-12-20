import { Environment } from '@abp/ng.core';

const baseUrl = 'http://localhost:4200';

export const environment = {
  production: true,
  application: {
    baseUrl,
    name: 'BookTutorialAbp',
    logoUrl: '',
  },
  oAuthConfig: {
    issuer: 'https://localhost:44315/',
    redirectUri: baseUrl,
    clientId: 'BookTutorialAbp_App',
    responseType: 'code',
    scope: 'offline_access BookTutorialAbp',
    requireHttps: true
  },
  apis: {
    default: {
      url: 'https://localhost:44315',
      rootNamespace: 'BookTutorialAbp',
    },
  },
} as Environment;
