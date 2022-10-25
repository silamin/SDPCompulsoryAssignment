import {Component, OnInit} from '@angular/core';
import {HttpService} from "../services/http.service";
import {faTimes} from '@fortawesome/free-solid-svg-icons';


@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./style.css'],

})
export class AppComponent implements OnInit{
  title = 'Frontend';
  boxes: any;
  faTimes =faTimes;


  async addBox(){
    const newBox= await this.http.createNewBox(document.getElementById('box-name'),
      document.getElementById('box-length'),
      document.getElementById('box-height'),
      document.getElementById('box-width'),
      document.getElementById('box-weight'),
      document.getElementById('box-description'),
      document.getElementById('box-picture'));
    console.log(newBox)
  }

  constructor(private http: HttpService) {

  }

  async ngOnInit() {
    //const boxes = await this.http.getProducts();
    //this.boxes=boxes.data;
    //console.log(boxes);
  }

  OpenForm() {

  }


}
