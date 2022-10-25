import {Injectable, OnInit} from '@angular/core';
import axios from 'axios';

export const customAxios = axios.create({
  baseURL: 'https://localhost:7171/'
})

@Injectable({
  providedIn: 'root'
})
export class HttpService{

  constructor() { }

  async getProducts() {
    const httpResponse =  await customAxios.get('Box/GetAllBoxes');
    console.log(httpResponse.data);
    return httpResponse.data;
  }

  async createNewBox(elementById: HTMLElement | null, elementById2: HTMLElement | null, elementById3: HTMLElement | null, elementById4: HTMLElement | null, elementById5: HTMLElement | null, elementById6: HTMLElement | null, elementById7: HTMLElement | null) {
    const httpResponse =  await customAxios.put('Box/CreateNewBox');
    return httpResponse.data;
  }
}
