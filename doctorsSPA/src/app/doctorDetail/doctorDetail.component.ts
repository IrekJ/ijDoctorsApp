import { Component, OnInit } from '@angular/core';
import { DataService } from '../services/data.service';
import { Detail } from '../interfaces/detail';


@Component({
  selector: 'app-doctor-detail',
  templateUrl: './doctorDetail.component.html',
  styleUrls: ['./doctorDetail.component.css']
})
export class DoctorDetailComponent implements OnInit {
  doctor: Detail;
  constructor(private dataService: DataService) { }

  ngOnInit() {
    this.dataService.getDoctor(1).subscribe(doc => {
      this.doctor = doc;
      console.log(this.doctor);
    });
   }
}
