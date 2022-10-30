import {Component, OnInit} from '@angular/core';
import {HttpService} from "../services/http.service";
import { faTimes } from '@fortawesome/free-solid-svg-icons';



@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['../styles.css'],

})
export class AppComponent implements OnInit{
  title = 'Frontend';
  boxes: any[]=[];
  boxName: string="";
  boxHeight: number=0;
  boxWidth: number=0;
  boxLength: number=0;
  boxWeight: number=0;
  boxDescription: string="";

  faTimes=faTimes;



  constructor(private http: HttpService) {

  }

  async ngOnInit() {
    const boxes = await this.http.getProducts();
    this.boxes=boxes;
  }

  async createBox(){
    let dto={
      name: this.boxName,
      description: this.boxDescription,
      length: this.boxLength,
      width: this.boxWidth,
      weight: this.boxWeight,
      boxImage: "",
      height: this.boxHeight
    }
    const result = await this.http.createBox(dto);
    this.boxes.push(result);
    console.log(result);
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
