import React from "react";
import { BrowserRouter, Redirect, Route, Switch } from "react-router-dom";
import { selectIsAuthenticated } from "../auth/state/authSelectors";
import LoginView from "../auth/views/LoginView/LoginView";
import RegisterView from "../auth/views/RegisterView/RegisterView";
import { BookDetailsView } from "../books/views/BookDetailsView";
import { BookInventoryView } from "../books/views/BookInventoryView";
import { useAppSelector } from "../config/hooks";
import { getBaseName } from "./AppRouter.helpers";
import AuthenticatedRoute from "./AuthenticatedRoute/AuthenticatedRoute";
import { Routes } from "./routes";

export const AppRouter: React.FC = () => {
  const basename = getBaseName();
  const isAuth = useAppSelector(selectIsAuthenticated);

  return (
    <BrowserRouter basename={basename}>
      <Switch>
        <Route path={"/"} exact>
          <Redirect to={isAuth ? Routes.HOME_PAGE : Routes.LOGIN} />
        </Route>
        <AuthenticatedRoute path={Routes.HOME_PAGE}>
          <BookInventoryView />
        </AuthenticatedRoute>
        <AuthenticatedRoute path={Routes.BOOK}>
          <BookDetailsView />
        </AuthenticatedRoute>
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
