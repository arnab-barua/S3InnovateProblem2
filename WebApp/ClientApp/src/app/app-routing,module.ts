import { CreateComponent } from './components/create/create.component';
import { ListViewComponent } from './components/list-view/list-view.component';
import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';

const routes: Routes = [
	{ path: '', component: ListViewComponent, pathMatch: 'full' },
	{ path: 'create', component: CreateComponent }
];

@NgModule({
	imports: [
		RouterModule.forRoot(routes, { onSameUrlNavigation: 'reload' })
	],
	exports: [RouterModule]
})
export class AppRoutingModule { }