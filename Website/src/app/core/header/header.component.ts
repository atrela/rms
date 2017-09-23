import { Component, Input } from '@angular/core';

@Component({
    selector: 'header',
    templateUrl: 'header.component.html'
})
export class HeaderComponent {
    @Input() title: string;
    @Input() smallTitle: string;
}
