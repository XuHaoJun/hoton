'use client'

import type { PropsWithChildren } from 'react'
import { YStack } from 'tamagui'

import { MainBottomTabs } from './MainBottomTabs'

export function MainLayoutWeb({ children }: PropsWithChildren<{}>) {
  return (
    <YStack flex={1} position='relative'>
      {children}
      <MainBottomTabs />
    </YStack>
  )
}

export default MainLayoutWeb
