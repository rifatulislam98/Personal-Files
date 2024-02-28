export class User {

  constructor(param: any = {}) {
    this.id = param.id || param.user_id;
    this.username = param.username;
    this.first_name = param.first_name;
    this.last_name = param.last_name;
    this.email = param.email;
    this.token = param.token;
    this.roles = param.roles;
  }

  id: string;
  username: string;
  first_name: string;
  last_name: string;
  email: string;
  roles: string[];
  address: string;
  address2: string;
  country: string;
  city: string;
  zipCode: string;
  token: string;

  isAdmin(): boolean {
    return this.roles && this.roles.findIndex(r => r === 'ROLE_ADMIN') !== -1;
  }

  isAuthor(): boolean {
    return this.roles && this.roles.findIndex(r => r === 'ROLE_AUTHOR') !== -1;
  }
}

export class UserDetail {
  $key: string;
  firstName: string;
  lastName: string;
  userName: string;
  emailId: string;
  address1: string;
  address2: string;
  country: string;
  state: string;
  zip: number;
}
