import { Navigate, Outlet } from "react-router-dom";
import { AccountModel } from "../../models/modelAccount";
import { AuthService } from "../../services/authService";

export const ProtectedRoute = ({ role }: any) => {
  const account: AccountModel = AuthService.getAccount();
  return AuthService.getToken() ? (
    account.roles.indexOf(role) > -1 ? (
      <Outlet />
    ) : (
      <Navigate to="/restricted" />
    )
  ) : (
    <Navigate to="/auth" />
  );
};
