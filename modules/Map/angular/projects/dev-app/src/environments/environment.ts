import { Config } from '@abp/ng.core';

export const environment = {
  production: false,
  application: {
    baseUrl: 'http://localhost:4200/',
    name: 'Map',
    logoUrl: '',
  },
  oAuthConfig: {
    issuer: 'https://localhost:44322',
    clientId: 'Map_ConsoleTestApp',
    dummyClientSecret: '1q2w3e*',
    scope: 'Map',
    oidc: false,
    requireHttps: true,
  },
  apis: {
    default: {
      url: 'https://localhost:44322',
      rootNamespace: 'IOT.Map',
    },
    Map: {
      url: 'https://localhost:44317',
      rootNamespace: 'IOT.Map',
    },
  },
} as Config.Environment;
