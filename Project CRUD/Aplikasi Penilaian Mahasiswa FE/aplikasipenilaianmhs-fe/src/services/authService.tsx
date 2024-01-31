import axios from "axios";
import { LoginModel } from "../models/modelLogin";
import { config } from "../configurations/config";
import { AccountModel } from "../models/modelAccount";

export const AuthService = {
  login: (auth: LoginModel) => {
    var result = axios
      .post(config.apiUrl + "/Account/login", auth)
      .then((respons) => {
        const account: AccountModel = respons.data;
        localStorage.setItem("userName", account.userName);
        localStorage.setItem("firstName", account.firstName);
        localStorage.setItem("lastName", account.lastName);
        localStorage.setItem("token", account.token);
        localStorage.setItem("roles", JSON.stringify(account.roles));
        console.log(account.roles);
        console.log(JSON.stringify(account.roles));
        return {
          success: respons.status === 200,
          status: respons.status,
          result: {
            email: account.email,
          },
        };
      })
      .catch((error) => {
        return {
          success: false,
          status: error.response.status,
          result: error.response.data,
          message: error.response.data,
        };
      });
    return result;
  },
  logout: () => {
    localStorage.clear();
  },
  getToken: () => {
    return localStorage.getItem("token");
  },
  getAccount: () => {
    let rolStr: any = localStorage.getItem("roles");
    let roles: string[] = JSON.parse(rolStr);
    let biodataId: string | null = localStorage.getItem("biodataId");

    console.log(roles);
    return {
      id: 0,
      userName: localStorage.getItem("userName") || "",
      firstName: localStorage.getItem("firstName") || "",
      lastName: localStorage.getItem("lastName") || "",
      active: true,
      email: "",
      token: "",
      roles: roles || [],
    };
  },
  forgot: (email: string) => {
    var result = axios
      .post(
        config.apiUrl + "/Account/SendOtp?email=" + email.replace("@", "%40")
      )
      .then((respons) => {
        const account: AccountModel = respons.data;

        console.log(account.roles);
        console.log(JSON.stringify(account.roles));
        return {
          success: respons.status === 200,
          status: respons.status,
          result: respons.data,
        };
      })
      .catch((error) => {
        return {
          success: false,
          status: error.response.status,
          result: error.response.data,
          message: error.response.data,
        };
      });
    return result;
  },
  verifikasiOtp: (otp: string) => {
    var result = axios
      .post(config.apiUrl + "/Account/VerifikasiOtp?Otp=" + otp)
      .then((respons) => {
        return {
          success: respons.status === 200,
          status: respons.status,
          result: respons.data,
        };
      })
      .catch((error) => {
        return {
          success: false,
          status: error.response.status,
          result: error.response.data,
          message: error.response.data,
        };
      });
    return result;
  },
};
