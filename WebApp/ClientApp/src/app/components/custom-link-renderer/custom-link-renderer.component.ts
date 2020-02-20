import { Component, OnInit } from '@angular/core';
import { ICellRendererAngularComp } from 'ag-grid-angular';

@Component({
  selector: 'app-custom-link-renderer',
  templateUrl: './custom-link-renderer.component.html',
  styleUrls: ['./custom-link-renderer.component.css']
})
export class CustomLinkRendererComponent implements ICellRendererAngularComp {

	public params: any;

	agInit(params: any): void {
		console.log(params);
		this.params = params;
	}

	public invokeParentMethod() {
		console.log(this.params.data.syllebusDocId);
		this.params.context.componentParent.onGetFile(this.params.data.syllebusDocId);
	}

	refresh(): boolean {
		return false;
	}

}
