import { Component, OnInit } from '@angular/core';
import { CommonModule } from '@angular/common';

@Component({
  selector: 'app-user',
  templateUrl: './user.component.html',
  styleUrls: ['./user.component.css']
})
export class UserComponent implements OnInit {
  name: string;
  age: number;
  hobbies:string[];

  constructor() { }

  ngOnInit() {
    this.age = 18;
    this.name = "Alexander";
    this.hobbies= ["listen to death metal, kill people"];
  }

}
