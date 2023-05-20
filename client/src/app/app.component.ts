import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent implements OnInit {
  title = 'My Dating App';
  users:any;

  constructor(private _http: HttpClient) {}

  ngOnInit()
  {
    this.getUsers();
  }

  getUsers()
  {
    this._http.get
    (`https://localhost:7051/api/User`)
      .subscribe(response => {
      this.users = response;

    }, err => console.log(err)
    )
  }

;
}
