import { Component,OnInit } from '@angular/core';
import { TicketService } from '../services/ticket.service';

@Component({
selector:'app-dashboard',
templateUrl:'./dashboard.component.html'
})

export class DashboardComponent implements OnInit{

tickets:any

constructor(private ticketService:TicketService){}

ngOnInit(){

this.ticketService.getTickets()
.subscribe(res=>{
this.tickets=res
})

}

}