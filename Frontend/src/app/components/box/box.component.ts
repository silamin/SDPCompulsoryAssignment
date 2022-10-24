import { Component, OnInit } from '@angular/core';
import {HttpService} from "../../../services/http.service";

@Component({
  selector: 'app-box',
  templateUrl: './box.component.html',
  styleUrls: ['./box.component.css']
})
export class BoxComponent implements OnInit {
  boxName: any;
  boxDescription: any;
  boxLength: any;
  boxWidth: any;
  boxType: any;

  types: any;

  constructor(private http: HttpService) { }

  async ngOnInit(){
    await this.getTypes();
  }

  private async getTypes() {
    const data = await this.http.getTypes();
    console.log(data);
    this.types = data;
  }

}
