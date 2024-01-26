export class ValidationBase {
  constructor(valid: boolean, message: string) {
    this.valid = valid;
    this.message = message;
  }
  valid: boolean;
  message: string;
}
