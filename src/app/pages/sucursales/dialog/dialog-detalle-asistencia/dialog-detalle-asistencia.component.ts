import { Component, Inject, OnInit } from '@angular/core';
import { MatDialogRef, MAT_DIALOG_DATA, MatDialog } from '@angular/material/dialog';
import { ServiceGeneralService } from 'app/core/services/service-general/service-general.service';
import { DialogDetalleTareaComponent } from '../dialog-detalle-tarea/dialog-detalle-tarea.component';

@Component({
  selector: 'app-dialog-detalle-asistencia',
  templateUrl: './dialog-detalle-asistencia.component.html',
  styleUrls: ['./dialog-detalle-asistencia.component.css']
})
export class DialogDetalleAsistenciaComponent implements OnInit {
  public user;
  public data;
  public taskId;
  public dataBranch: any[] = [];
  public nameBranch = '';
  public status;
  public url = 'http://operamx.mooo.com/back/api_rebel_wings/';
  
  constructor(public dialogRef: MatDialogRef<DialogDetalleTareaComponent>,
    @Inject(MAT_DIALOG_DATA) public param: any,
    public services: ServiceGeneralService,
    public _dialog: MatDialog) { }

  ngOnInit(): void {
    console.log("data que recibe", this.param);
    this.data = this.param;
    this.user = JSON.parse(localStorage.getItem("userData"));
    console.log("user", this.user);
    this.getBranch();
  }

  close() {
    this.dialogRef.close();
  }

  // get  name sucursal
  getBranch() {

    this.services.serviceGeneralGet(`StockChicken/Admin/All-Branch?dataBase=${this.data.baseDatos}`).subscribe(resp => {
      if (resp.success) {
        this.dataBranch = resp.result;
        console.log('get branch', this.dataBranch);
        this.dataBranch.forEach(element => {
          if (this.data.data.branch) {
            if (element.branchId === this.data.data.branch) {
              this.nameBranch = element.branchName;
              this.nameBranch = this.nameBranch.toUpperCase();
              console.log('nombre', this.nameBranch);
            }
          }
          else {
            if (element.branchId === this.data.data.branchId) {
              this.nameBranch = element.branchName;
              this.nameBranch = this.nameBranch.toUpperCase();
              console.log('nombre', this.nameBranch);
            }
          }
        });
      }
    });
  }

}
