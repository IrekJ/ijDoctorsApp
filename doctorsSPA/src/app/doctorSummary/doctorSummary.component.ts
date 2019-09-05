import { Component, OnInit } from '@angular/core';
import { DataService } from '../services/data.service';
import { Summary } from '../interfaces/summary';


@Component({
  selector: 'app-doctor-summary',
  templateUrl: './doctorSummary.component.html',
  styleUrls: ['./doctorSummary.component.css']
})
export class DoctorSummaryComponent implements OnInit {
  doctors: Summary[];
  constructor(private dataService: DataService) { }

  ngOnInit() {
    this.dataService.getDoctors().subscribe(docs => {
      this.doctors = docs;
    });
  }

}
