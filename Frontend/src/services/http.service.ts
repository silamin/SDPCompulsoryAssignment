import {Injectable} from '@angular/core';
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
    const httpResponse =  await customAxios.get<any>('box');
    return httpResponse.data;
  }

  async createProduct(boxDTO: { boxTypeId: any; name: any; length: any; width: any; description: any }) {
    return await customAxios.post('box',boxDTO);
  }
}
