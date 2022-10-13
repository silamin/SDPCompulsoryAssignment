import {Component, OnInit} from '@angular/core';
import {HttpService} from "../services/http.service";

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent implements OnInit{
  title = 'Frontend';
  productName: string = "";
  boxes: any;


  boxName: any;
  boxDescription: any;
  boxLength: any;
  boxWidth: any;
  boxTypeID: any;

  constructor(private http: HttpService) {

  }

  async ngOnInit() {
    const products = await this.http.getProducts();
    console.log(products);
    this.boxes = products;
  }

  writeBoxName() {
    console.log(this.productName);
  }

  async createBox() {
    let boxDTO = {
      name: this.boxName,
      description: this.boxDescription,
      length: this.boxLength,
      width: this.boxWidth,
      boxTypeId: this.boxTypeID
    }
    const result = await this.http.createProduct(boxDTO);
    this.boxes.push(result);

  }
}
