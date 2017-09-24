export class PartitionTile {
    public header: string;
    public subHeader: string;
    public agentsCount: number;
    public panelClass: string;

    constructor(header: string, subHeader: string, agentsCount: number, panelClass: string) {
        this.header = header;
        this.subHeader = subHeader;
        this.agentsCount = agentsCount;
        this.panelClass = panelClass;
    }
}