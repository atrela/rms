export class PartitionTile {
    public id: number;
    public header: string;
    public subHeader: string;
    public agentsCount: number;
    public panelClass: string;

    constructor(id: number, header: string, subHeader: string, agentsCount: number, panelClass: string) {

        this.id = id;
        this.header = header;
        this.subHeader = subHeader;
        this.agentsCount = agentsCount;
        this.panelClass = panelClass;
    }
}