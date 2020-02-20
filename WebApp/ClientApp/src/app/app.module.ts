import { GridPaginationComponent } from './components/grid-pagination/grid-pagination.component';
import { AppRoutingModule } from './app-routing,module';
import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { HttpClientModule, HTTP_INTERCEPTORS } from '@angular/common/http';
import { RouterModule } from '@angular/router';
import { BsDatepickerModule } from 'ngx-bootstrap';
import { ToastrModule } from 'ngx-toastr';
import { NgxDatatableModule } from '@swimlane/ngx-datatable';
import { AgGridModule } from 'ag-grid-angular';

import { AppComponent } from './app.component';
import { NavMenuComponent } from './components/nav-menu/nav-menu.component';;
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { ListViewComponent } from './components/list-view/list-view.component';
import { CreateComponent } from './components/create/create.component';
import { CustomLinkRendererComponent } from './components/custom-link-renderer/custom-link-renderer.component';

@NgModule({
  declarations: [
    AppComponent,
    NavMenuComponent,
    ListViewComponent,
	CreateComponent,
	GridPaginationComponent,
	CustomLinkRendererComponent
  ],
  imports: [
	BrowserModule.withServerTransition({ appId: 'ng-cli-universal' }),
	AgGridModule.withComponents([
		CustomLinkRendererComponent
	]),
	NgxDatatableModule,
    HttpClientModule,
	FormsModule,
	BrowserAnimationsModule,
    AppRoutingModule,
	BsDatepickerModule.forRoot(),
	ToastrModule.forRoot({
		timeOut: 5000,
		positionClass: 'toast-center-center',
		preventDuplicates: true,
		closeButton: true,
		enableHtml: true
	})
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
