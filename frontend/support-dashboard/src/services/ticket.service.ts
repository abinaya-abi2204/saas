import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';

@Injectable({
  providedIn:'root'
})

export class TicketService{

API="http://localhost:5000/api/ticket"

constructor(private http:HttpClient){}

getTickets(){
return this.http.get(this.API)
}

}