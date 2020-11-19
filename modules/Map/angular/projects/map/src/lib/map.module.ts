import { NgModule, NgModuleFactory, ModuleWithProviders } from '@angular/core';
import { CoreModule, LazyModuleFactory } from '@abp/ng.core';
import { ThemeSharedModule } from '@abp/ng.theme.shared';
import { MapComponent } from './components/map.component';
import { MapRoutingModule } from './map-routing.module';

@NgModule({
  declarations: [MapComponent],
  imports: [CoreModule, ThemeSharedModule, MapRoutingModule],
  exports: [MapComponent],
})
export class MapModule {
  static forChild(): ModuleWithProviders<MapModule> {
    return {
      ngModule: MapModule,
      providers: [],
    };
  }

  static forLazy(): NgModuleFactory<MapModule> {
    return new LazyModuleFactory(MapModule.forChild());
  }
}
