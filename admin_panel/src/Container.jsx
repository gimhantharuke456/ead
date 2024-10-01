import React, { useEffect } from "react";
import Dashboard from "./pages/Dashboard";
import { useNavigate } from "react-router-dom";

const Container = () => {
  const navigate = useNavigate();
  const admin = localStorage.getItem("admin");
  useEffect(() => {
    if (!admin) {
      navigate("/login");
    }
  }, [admin]);
  return (
    <>
      <Dashboard />
    </>
  );
};

export default Container;
