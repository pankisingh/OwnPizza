import { Injectable } from "@angular/core";
import { HttpClient } from "@angular/common/http";
import { Observable } from "rxjs";
import { environment } from "src/environments/environment";
import { map } from "rxjs/operators";
import { Product } from "../models/product";

@Injectable({
  providedIn: "root"
})
export class ProductService {
  
  public api_url = environment.apiServer_url + 'api/Values/GetProduct';
  
  constructor( private http: HttpClient) { }

  getProducts(): Observable<Product[]> { 
    return this.http.get<Product[]>(this.api_url).pipe(
      map((result: any) => {
        return result.data;
      })
    );
    
  }

}
