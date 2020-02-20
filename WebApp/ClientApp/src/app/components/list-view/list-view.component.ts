
import { SyllebusService } from './../../services/syllebus.service';
import { Component, OnInit } from '@angular/core';
import { saveAs } from 'file-saver';
import { CustomLinkRendererComponent } from '../custom-link-renderer/custom-link-renderer.component';

@Component({
	selector: 'app-list-view',
	templateUrl: './list-view.component.html',
	styleUrls: ['./list-view.component.css']
})
export class ListViewComponent implements OnInit {

	colDef = [
		{ headerName: "Name", field: "syllebusName" },
		{ 
			headerName: "Syllebus", 
			cellRenderer: "matchingButtonRenderer"
		},
		{ headerName: "Trade", field: "tradeName" },
		{ headerName: "Level", field: "levelName" },
		{ headerName: "Development officer", field: "developmentOfficer" },
		{ headerName: "Manager", field: "manager" },
		{ headerName: "Language", field: "languages" },
		
		{ headerName: "Test plan", field: "testPlanDoc" },
	];

	defaultColDefActionType = {      
		sortable: true,
		filter: true
	};

	rowData: any;
	totalDbRecords : number = 0;

	context = { componentParent: this };
	frameworkComponents;

	constructor(private syllebusService: SyllebusService) {
		this.frameworkComponents = {
			matchingButtonRenderer: CustomLinkRendererComponent
		};
	}

	ngOnInit() {
		this.syllebusService.getAll()
			.subscribe(
				(response: any) => {
					console.log(response);
					this.rowData = response;
				},
				error => {
					console.log(error);
				}
			)
	}


	onGetFile(fileId) {
		console.log(fileId);
		//saveAs('/api/Risorse/GetRisorseCV/');
	}
}
