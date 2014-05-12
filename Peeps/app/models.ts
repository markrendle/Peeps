module Peeps {
    export interface IPhoneNumber {
        type: string;
        countryCode: string;
        areaCode: string;
        number: string;
    }
    export interface IAddress {
        line1: string;
        line2: string;
        town: string;
        county: string;
        country: string;
        postalCode: string;
    }
    export interface IPeep {
        title: string;
        firstName: string;
        lastName: string;
        address: IAddress;
        phoneNumbers: IPhoneNumber[];
    }
    export interface IPeepCollection {
        peeps: IPeep[];
    }
} 