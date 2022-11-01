import {Injectable, OnInit} from '@angular/core';
import axios from 'axios';
import {readSpanComment} from "@angular/compiler-cli/src/ngtsc/typecheck/src/comments";
import {MatSnackBar} from "@angular/material/snack-bar";
import {catchError} from "rxjs";

export const customAxios = axios.create({
  baseURL: 'https://localhost:7171/'
})

@Injectable({
  providedIn: 'root'
})
export class HttpService{

  constructor(private matSnackBar : MatSnackBar) {
    customAxios.interceptors.response.use(
      response => {
        console.log(response.status);
        if (response.status==201){
            this.matSnackBar.open("great success");
        }return response;
      },rejected=>{
        if (rejected.response.status>=400 && rejected.response.status<500){
          this.matSnackBar.open(rejected.response.data);
        }else if(rejected.response.data>499){
          this.matSnackBar.open("Something went wrong ")
        }
        catchError(rejected);
        return rejected;
      }
    )
  }

  async getProducts() {
    const httpResponse =  await customAxios.get('Box/GetAllBoxes');
    console.log(httpResponse.data);
    return httpResponse.data;
  }

  async createBox(dto: {name: string; description: string; length: number; width: number;  weight: number; boxImage: string; height: number }) {
    const httpResult= await customAxios.post('Box/CreateNewBox',dto);
    return httpResult.data;
  }

  async deleteBox(id: any) {
    const httpResponse= await customAxios.delete('Box/DeleteBox?boxId='+id);
    return httpResponse.data;
  }
}
