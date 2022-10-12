import {Component, OnInit} from '@angular/core';
import {HttpService} from "../services/http.service";

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent implements OnInit{
  title = 'Frontend';//Not needed

  constructor(private http: HttpService) {

  }

  async ngOnInit() {
    const products = await this.http.getProducts();
    console.log(products);
  }
}
