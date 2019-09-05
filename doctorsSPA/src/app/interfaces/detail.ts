import { Rating } from './rating';

export interface Detail {
    name: string;
    gender: string;
    medicalSchool: string;
    languages: string[];
    specialties: string[];
    patientRatings: Rating[];
    average: number;
}
