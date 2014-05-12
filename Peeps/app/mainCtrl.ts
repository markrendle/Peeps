module Peeps {
    export class MainCtrl {
        public peeps: IPeep[];
        constructor($http: ng.IHttpService) {
            $http.get("/peeps")
                .success((data: IPeepCollection) => {
                    this.peeps = data.peeps;
                });
        }
    }
} 