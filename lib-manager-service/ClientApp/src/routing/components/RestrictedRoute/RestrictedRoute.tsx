import React from "react";
import { Redirect, Route } from "react-router-dom";
import { UserType } from "../../../auth/state/auth.types";
import {
  selectAuthUserType,
  selectIsAuthenticated,
} from "../../../auth/state/authSelectors";
import { Menu } from "../../../common/components/Menu/Menu";
import { useAppSelector } from "../../../config/hooks";
import { Routes } from "../../routes";
interface Props {
  path: string;
  userType: UserType;
}

const RestrictedRoute: React.FC<Props> = ({ path, children, userType }) => {
  const isAuth = useAppSelector(selectIsAuthenticated);
  const authUserType = useAppSelector(selectAuthUserType);

  return (
    <Route path={path}>
      {isAuth && userType === authUserType ? (
        <Menu>{children}</Menu>
      ) : (
        <Redirect to={Routes.LOGIN} />
      )}
    </Route>
  );
};

export default RestrictedRoute;
