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


  async getTypes() {
    const typeResponse = await customAxios.get("BoxType");
    return typeResponse.data;
  }

  async createProduct(boxDTO: { name: any; description: any; length: any; width: any; height: any;  boxTypeId: any; }) {
    return await customAxios.post('box',boxDTO);
  }

  async deleteBox(entry: any) {
    await customAxios.delete('Box/Delete/'+entry);
  }

  async editBox(entry: any) {

  }
}
