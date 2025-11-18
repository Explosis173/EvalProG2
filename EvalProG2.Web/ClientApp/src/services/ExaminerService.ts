// src/services/ExaminerService.ts
import axios from "axios";
import type {Examiner} from "@/models/examiner.ts";

const api = axios.create({
  baseURL: "https://localhost:5001/api",
  headers: {
    "Content-Type": "application/json",
  },
});

export const ExaminerService = {
  async getAll(): Promise<Examiner[]> {
    const res = await api.get("/Examiner");
    return res.data;
  },

  async add(examiner: any) {
    const res = await api.post("/Examiner", examiner);
    return res.data;
  },

  async update(examiner: any) {
    const res = await api.put("/Examiner", examiner);
    return res.data;
  },

  async delete(id: number) {
    const res = await api.delete(`/Examiner/${id}`);
    return res.data;
  },
};
