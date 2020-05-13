import { Component, OnInit } from '@angular/core';
import { Persona } from '../models/persona';

import { PersonaService } from '../services/persona.service';


@Component({
  selector: 'app-search',
  templateUrl: './search.component.html',
  styleUrls: ['./search.component.css']
})
export class SearchComponent implements OnInit {

  liqs:Persona[];

  constructor( private pS:PersonaService ) {
    this.liqs = new Array<Persona>();
  }

  ngOnInit() {
    this.pS.get().subscribe (
      (data) => {
        if(data==null){
          this.liqs = new Array<Persona>();
          this.liqs.push(new Persona);
        }
        else {
          this.liqs = data;
        }
      }
    );
  }

}
