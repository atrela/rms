import { BreadCrumbItem } from './bread-crumb-item';

export class NavBreadCrumbItem extends BreadCrumbItem {
    public url: string;

    constructor(text: string, url: string) {
        super(text);
        this.url = url;
    }
}