import "./App.css";
import { BrowserRouter } from "react-router-dom";
import SideBar from "./components/layout/sideBar";

function App() {
  return (
    <BrowserRouter>
      <SideBar />
    </BrowserRouter>
  );
}

export default App;
