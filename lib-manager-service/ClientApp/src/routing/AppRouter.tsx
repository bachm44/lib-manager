import React from "react";
import { BrowserRouter, Redirect, Route, Switch } from "react-router-dom";
import { UserType } from "../auth/state/auth.types";
import {
  selectAuthUserType,
  selectIsAuthenticated,
} from "../auth/state/authSelectors";
import LoginView from "../auth/views/LoginView/LoginView";
import RegisterView from "../auth/views/RegisterView/RegisterView";
import { Menu } from "../common/components/Menu/Menu";
import { useAppSelector } from "../config/hooks";
import { BookInventoryView } from "../librarian/views/BookInventoryView";
import { getBaseName } from "./AppRouter.helpers";
import { Routes } from "./routes";

export const AppRouter: React.FC = () => {
  const basename = getBaseName();
  const isAuth = useAppSelector(selectIsAuthenticated);
  const userType = useAppSelector(selectAuthUserType);

  return (
    <BrowserRouter basename={basename}>
      <Switch>
        <Route path={"/"} exact>
          <Redirect to={isAuth ? Routes.HOME_PAGE : Routes.LOGIN} />
        </Route>
        <Route path={Routes.HOME_PAGE}>
          <Menu>
            {userType === UserType.LIBRARIAN ? (
              <BookInventoryView />
            ) : (
              <>Reader view</>
            )}
          </Menu>
        </Route>
        <Route path={Routes.LOGIN}>
          <LoginView />
        </Route>
        <Route path={Routes.REGISTER}>
          <RegisterView />
        </Route>
      </Switch>
    </BrowserRouter>
  );
};
