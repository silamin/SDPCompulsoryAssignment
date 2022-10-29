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
    let unit : string = (<HTMLInputElement>document.getElementById("myUnit")).value;

    //const boxes = await this.http.getProducts();
    //this.boxes=boxes;
  }

  preFillForm() {
    const nameInput = document.getElementById('box-name') as HTMLInputElement;
    const boxDescriptionInput = document.getElementById('box-description') as HTMLInputElement;
    const boxName = document.getElementById('name-input') as HTMLInputElement;
    const boxDescription = document.getElementById('description-input') as HTMLInputElement;

  boxName.value=nameInput.value;
  boxDescription.value=boxDescriptionInput.value;

  }
}
