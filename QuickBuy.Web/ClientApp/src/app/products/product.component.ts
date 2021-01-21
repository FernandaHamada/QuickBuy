import { Component } from '@angular/core';

@Component({
  selector: 'qb-product',
  template: '<html><body>{{ getName() }}</body></html>'
})
export class ProductComponent {
  public name: string;
  public liberadoVenda: boolean;

  public getName(): string {
    return "Samsung";
  }
}
