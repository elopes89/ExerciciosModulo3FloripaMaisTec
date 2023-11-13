import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup } from '@angular/forms';
import { IUsuario } from 'IUsuario';
import { IntegracaoService } from 'src/app/service/integracao.service';

@Component({
  selector: 'app-cadastro',
  templateUrl: './cadastro.component.html',
  styleUrls: ['./cadastro.component.css']
})

export class CadastroComponent implements OnInit {
  registerForm!: FormGroup;
  usuarios: Array<IUsuario> = []
  constructor(private integracao: IntegracaoService, private builder: FormBuilder) {

  }


  ngOnInit(): void {
    this.registerForm = this.builder.group({
      codigo: [''],
      nome: [''],
      dataDeNascimento: [],
      email: ['']
    })
  }
  enviar() {
    this.integracao.add(this.registerForm.value).subscribe(user => {
      this.usuarios.push(user);
      console.log(this.registerForm.value)
    })
  }
}
