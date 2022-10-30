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

  async createBox(dto: {name: string; description: string; length: number; width: number;  weight: number; boxImage: string; height: number }) {
    return await customAxios.post('Box/CreateNewBox');
  }
}
