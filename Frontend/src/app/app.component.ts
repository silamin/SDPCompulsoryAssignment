import {Component, OnInit} from '@angular/core';
import {HttpService} from "../services/http.service";


@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['../styles.css'],

})
export class AppComponent implements OnInit{
  title = 'Frontend';
  boxes: any[]=[];

  constructor(private http: HttpService) {

  }

  async ngOnInit() {
    //const boxes = await this.http.getProducts();
    //this.boxes=boxes;
  }

  OpenForm() {

  }
}
