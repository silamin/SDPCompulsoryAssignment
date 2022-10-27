import {Component, OnInit, ViewChild} from '@angular/core';
import {HttpService} from "../services/http.service";
import {MatDialog} from "@angular/material/dialog";
import {BoxComponent} from "./components/box/box.component";
import {MatTable} from "@angular/material/table";


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


  displayedColumns: any;

  constructor(private http: HttpService,
              public dialog: MatDialog) {

  }

  async ngOnInit() {
    const products = await this.http.getProducts();
    console.log(products);
    this.boxes = products;
  }

  writeBoxName() {
    console.log(this.productName);
  }

  openBoxForm() {
    let dialogRef = this.dialog.open(BoxComponent, {
      height: '500px',
      width: '300px',
    });

    //The most stupid thing ever, why is the no way to just make it check the change and reflect it on the table
    dialogRef.afterClosed().subscribe(
      data => {
        this.boxes = [...this.boxes,data.data];
      }
    )
  }

  async editBox(entry: any) {
    let dialogRef = this.dialog.open(BoxComponent, {
      height: '500px',
      width: '300px',
    });

    //TODO
    dialogRef.componentInstance.ShowData(entry);

    let boxToEdit = {
      id: entry.id,
      name: 'working',
      description: 'hard',
      length: '1',
      width: '2',
      height: '3',
      boxTypeId:'1'
    }

    console.log(entry.id);
    //To reflect change on entity we could retrieve the entity from the db and then just update it
    await console.log(this.http.editBox(boxToEdit));
  }

  async deleteBox(entry: any) {
    //TODO
    console.log(entry);
    await this.http.deleteBox(entry.id);
    this.boxes = this.boxes.filter((box: { id: any; }) => box.id !== entry.id);
  }
}


