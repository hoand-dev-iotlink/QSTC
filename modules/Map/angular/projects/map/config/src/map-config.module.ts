import { ModuleWithProviders, NgModule } from '@angular/core';
import { MAP_ROUTE_PROVIDERS } from './providers/route.provider';

@NgModule()
export class MapConfigModule {
  static forRoot(): ModuleWithProviders<MapConfigModule> {
    return {
      ngModule: MapConfigModule,
      providers: [MAP_ROUTE_PROVIDERS],
    };
  }
}
