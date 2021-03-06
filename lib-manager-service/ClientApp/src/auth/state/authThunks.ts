import { createAsyncThunk } from "@reduxjs/toolkit";
import { setAxiosToken, storeToken } from "./auth.helpers";
import { UserCredentials } from "./auth.types";
import { loginApi, registerApi } from "./authApi";

export const loginAsync = createAsyncThunk(
  "auth/login",
  async (creds: UserCredentials) => {
    const response = await loginApi(creds);
    const token = response?.token ?? null;

    storeToken(token);
    setAxiosToken(token);

    return token !== null;
  }
);

export const registerAsync = createAsyncThunk(
  "auth/register",
  async (creds: UserCredentials) => {
    const response = await registerApi(creds);
    const token = response?.token ?? null;

    if (response === null) {
      return false;
    }

    storeToken(token);
    setAxiosToken(token);

    return token !== null;
  }
);
