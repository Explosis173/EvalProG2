<script setup lang="ts">
import { RouterView } from "vue-router";
import { ExaminerService } from "@/services/ExaminerService";
import {ref, onMounted, type Ref} from "vue";
import type {Examiner} from "@/models/examiner.ts";

const examiners: Ref<Examiner[]> = ref([]);

onMounted(async () => {
  const res = await ExaminerService.getAll();
  examiners.value = res;
});
</script>

<template>
  <div class="layout">
    <header class="app-header">
      <div class="brand">
        <img src="@/images/logo.jpg" class="brand-logo" alt="Logo" />
        <h1 class="brand-title">EvalPro</h1>
      </div>
    </header>
    <p>{{ examiners }}</p>
    <div class="layout-body">
      <main class="app-content">
        <RouterView />
      </main>
    </div>
  </div>
</template>

.layout {
  display: flex;
  flex-direction: column;
  width: 100%;
  min-height: 100vh;
}

.layout-body {
  flex: 1;
  display: flex;
  justify-content: flex-start;
  align-items: flex-start;
  width: 100%;
}

<style scoped>
/* Premium Sticky Header */
.app-header {
  position: sticky;
  top: 0;
  width: 100%;
  padding: 0.75rem 1.5rem;

  display: flex;
  align-items: center;

  backdrop-filter: blur(12px);
  background: rgba(20, 20, 20, 0.55);

  border-bottom: 1px solid rgba(255, 255, 255, 0.08);
  box-shadow: 0 2px 8px rgba(0, 0, 0, 0.35);

  z-index: 999;
}

/* Logo + Titel */
.brand {
  display: flex;
  align-items: center;
  gap: 0.75rem;
}

.brand-logo {
  width: 38px;
  height: 38px;
  object-fit: contain;
}

.brand-title {
  font-size: 1.4rem;
  font-weight: 600;
  color: white;
  margin: 0;
}

/* Main Content */
.app-content {
  width: 100%;
  padding: 1.5rem;
  color: white;
}
</style>
