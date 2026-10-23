import { Component } from '@angular/core';
import { FormsModule } from '@angular/forms';

@Component({
  selector: 'app-register',
  imports: [FormsModule],
  templateUrl: './register.html',
  styleUrl: './register.css'
})
export class Register {

  fullName: string = '';
  address: string = '';
  gender: string = '';

  hobbies = {
    cricket: false,
    cooking: false,
    swimming: false
  };

  country: string = '';
  email: string = '';
  photo: File | null = null;

  onPhotoSelected(event: Event) {
    const input = event.target as HTMLInputElement;

    if (input.files && input.files.length > 0) {
      this.photo = input.files[0];
    }
  }

  onSubmit() {
    console.log('Full Name:', this.fullName);
    console.log('Address:', this.address);
    console.log('Gender:', this.gender);
    console.log('Hobbies:', this.hobbies);
    console.log('Country:', this.country);
    console.log('Email:', this.email);
    console.log('Photo:', this.photo);

    alert('Registration Successful!');
  }
}
