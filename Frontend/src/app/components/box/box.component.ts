import { Component, OnInit } from '@angular/core';
import {HttpService} from "../../../services/http.service";
import {MatDialogRef} from "@angular/material/dialog";
import {FormBuilder, FormGroup, Validators} from "@angular/forms";


@Component({
  selector: 'app-box',
  templateUrl: './box.component.html',
  styleUrls: ['./box.component.css']
})
export class BoxComponent implements OnInit {
  types: any;

  boxForm !: FormGroup;
  Box: any;

  constructor(private http: HttpService,
              private dialogRef: MatDialogRef<BoxComponent>,
              private formBuilder: FormBuilder) { }


  async ngOnInit(){
    this.createForm();
    await this.getTypes();
  }

  private createForm() {
    this.boxForm = this.formBuilder.group({
      boxName: ["",Validators.required],
      boxDescription: ["",Validators.required],
      boxLength: ["",Validators.required],
      boxHeight: ["",Validators.required],
      boxWidth: ["",Validators.required],
      boxType: ["",Validators.required]
    })
  }

  private async getTypes() {
    const data = await this.http.getTypes();
    this.types = data;
  }

  async saveBox() {
    let boxDTO = {
      name: this.boxForm.get("boxName")?.value,
      description: this.boxForm.get("boxDescription")?.value,
      length: this.boxForm.get("boxLength")?.value,
      width: this.boxForm.get("boxHeight")?.value,
      height: this.boxForm.get("boxWidth")?.value,
      boxTypeId: 1
    }

    const result = await this.http.createProduct(boxDTO);


    this.dialogRef.close(result);
  }

  ShowData(entry: any) {
    this.Box = entry;

  }
}


