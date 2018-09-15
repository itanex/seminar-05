namespace Seminar.View.Auto {
    export class AutoController {
        private autoResource: ng.resource.IResourceClass<Models.Auto>;

        public filter: string = '';
        public message: string = 'Hello World';

        public autoViews: Models.Auto[] = [];
        public autos: Models.Auto[] = [];

        static $inject = [
            '$resource'
        ];

        constructor(
            $resource: ng.resource.IResourceService
        ) {
            this.autoResource = $resource<Models.Auto>('api/autos');

            this.autos = this.autoResource.query();
            this.autoViews = this.autos;
        }

        // event handlers

        /**
         * Filter Method to bind to filter control
         */
        public filterAutos(): void {
            this.autoViews = this.autos
                .filter((item: Models.Auto): boolean => {
                    return item.make.indexOf(this.filter) > -1;
                })
        }
    }
}