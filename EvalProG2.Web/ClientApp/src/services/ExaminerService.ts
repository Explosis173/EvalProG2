import axios from "axios";

const api = axios.create({
  baseURL: "https://localhost:5001/api/Examiner"
});

// GET – alle Examiner holen
export async function getAllExaminer() {
  return await api.get("/");
}

// POST – Examiner hinzufügen
export async function addExaminer(examiner) {
  return await api.post("/", null, {
    params: examiner
  });
}

// PUT – Examiner updaten
export async function updateExaminer(examiner) {
  return await api.put("/", null, {
    params: examiner
  });
}

// DELETE – Examiner löschen
export async function deleteExaminer(id) {
  return await api.delete("/", {
    params: { id }
  });
}
