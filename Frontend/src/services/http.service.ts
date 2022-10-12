import {Injectable, OnInit} from '@angular/core';
import axios from 'axios';

export const customAxios = axios.create({
  baseURL: 'http://localhost:8080'
})

@Injectable({
  providedIn: 'root'
})
export class HttpService{

  constructor() { }

  async getProducts() {
    const httpResponse =  await customAxios.get<any>('box');
    httpResponse.data;
  }
}
